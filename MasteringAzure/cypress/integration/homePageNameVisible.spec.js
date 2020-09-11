describe('Test the homepage', () => {
    beforeEach(() => {
        cy.visit("/");
    });

    it('Displays cookie accept', () => {
        cy.contains('Use this space to summarize your privacy and cookie use policy.')
            .should('be.visible');
    });

    it('Accept cookie accept', () => {
        cy.get('[data-cy=ma-cookie-accept]').click();
        cy.contains('Use this space to summarize your privacy and cookie use policy.')
            .should('not.be.visible');
    });

    it('Accept cookie accept then Displays the correct title', () => {
        cy.get('[data-cy=ma-cookie-accept]').click();
        cy.contains('Mastering Azure')
            .should('be.visible');
    });
});