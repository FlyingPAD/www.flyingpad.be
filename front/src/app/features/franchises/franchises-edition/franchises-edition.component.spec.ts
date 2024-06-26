import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FranchisesEditionComponent } from './franchises-edition.component';

describe('FranchisesEditionComponent', () => {
  let component: FranchisesEditionComponent;
  let fixture: ComponentFixture<FranchisesEditionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FranchisesEditionComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FranchisesEditionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
